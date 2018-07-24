var tareasInfraccion;
var idinfraccionc = '5';
function ConsultarListaInfraccion()
{
    var settings = {
        "async": true,
        "crossDomain": true,
        "url": "http://localhost:85/_vti_bin/ListData.svc/ListaInfracciones(" + idinfraccionc + ")",
        "method": "GET",
        "headers": {
            "accept": "application/json",
            "cache-control": "no-cache",
            "postman-token": "991ee2b3-8f6b-fa47-aaa6-497098780468"
        }
    }

    $.ajax(settings).done(function (response) {
        MostrarCampos(response.d, idinfraccionc)
        ConsultarDocumetos(idinfraccionc);
    });
}


function ConsultarDocumetos(idinfraccion)
{
    var settings = {
        "async": true,
        "crossDomain": true,
        "url": "http://localhost:85/_vti_bin/ListData.svc/DocumentosInfraccion?%24filter=(IdInfraccion%20eq%20" + idinfraccion + ")",
        "method": "GET",
        "headers": {
            "accept": "application/json",
            "cache-control": "no-cache",
            "postman-token": "dcc4a717-44f3-c83b-b484-3a49df636c76"
        }
    }

    $.ajax(settings).done(function (response) {
        InsertarTablaDocumentos(response.d)
    });
}


function ConsultarTareas(idinfraccion)
{
    var settings = {
        "async": true,
        "crossDomain": true,
        "url": "http://localhost:85/_vti_bin/Lists.asmx?op=GetListItems",
        "method": "POST",
        "headers": {
            "content-type": "text/xml; charset=utf-8",
            "content-length": "10000",
            "soapaction": "http://schemas.microsoft.com/sharepoint/soap/GetListItems",
            "cache-control": "no-cache",
            "postman-token": "0d4c0415-07c4-82ba-cdba-792964734b34"
        },
        "data": "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">\r\n  <soap:Body>\r\n    <GetListItems xmlns=\"http://schemas.microsoft.com/sharepoint/soap/\">\r\n      <listName>Tareas</listName>\r\n      <query><Query><Where><Neq><FieldRef Name='PercentComplete' /><Value Type='Number'>1.0</Value></Neq></Where></Query></query>\r\n    </GetListItems>\r\n  </soap:Body>\r\n</soap:Envelope>"
    }


    $.ajax(settings).done(function (response) {
        var jsonTareas = x2js.xml2json(tareasxml)
        if (response.d.results.length > 0) {
            var items = response.d.results;
            var desc;
            desc = FiltarTareas(response.d.results, idinfraccion);
            ConsultarDocumetos(idinfraccion);
        }
    });
}



function InsertarTablaDocumentos(documentos)
{
    $("#resultados").empty();
    var markup = "<tr><td></td><td>Título</td><td>Numero de Radicado</td></tr>"
    jQuery.each(documentos.results, function (index, item) {
         markup += "<tr><td></td><td>" + item.Título + "</td><td>" + item.NumeroRadicado + "</td></tr>";
    });
    $("#resultados").append(markup);
}

function MostrarCampos(resultado, idinfraccion)
{
    $("#tituloinfraccion").text(resultado.Título);
    $("#radicado").text(resultado.NumeroRadicado);
    $("#descarioninfraccion").text(resultado.Infraccion);
    $("#fecharadicado").text(resultado.FechaRadicado);
    $("#tituloinfraccion").val(resultado.Título);
    $("#radicado").val(resultado.NumeroRadicado);
    $("#descarioninfraccion").val(resultado.Infraccion);
    $("#fecharadicado").val(resultado.FechaRadicado);
    $("#idinfraccion").val(idinfraccion);
}

function Generardocumento()
{
    var tipo = "Auto";
    var dNow = new Date();
    var fecha = (dNow.getMonth() + 1).toString() + dNow.getDate().toString() + dNow.getFullYear().toString() + "_" + dNow.getHours().toString() + dNow.getMinutes().toString();
    var idinfraccion = $("#idinfraccion").val();
    var nombreoducmento = tipo + "_" + fecha + "_" + idinfraccion;
    var settings = {
        "async": true,
        "crossDomain": true,
        "url": "http://localhost:85/_vti_bin/ListData.svc/DocumentosInfraccion",
        "method": "POST",
        "headers": {
            "slug": "/DocumentosInfraccion/" + nombreoducmento + ".docx|0x0101",
            "accept": "application/json;odata=verbose",
            "x-requestdigest": "$(\\\"#__REQUESTDIGEST\\\").val()",
            "content-type": "application/json;odata=verbose",
            "cache-control": "no-cache",
            "postman-token": "ed5a6943-5a09-d4c3-1a58-b0ba7d4810c8"
        }
    }

    $.ajax(settings).done(function (response) {
        var objetoActualizar = response.d;
        objetoActualizar.IdInfraccion = idinfraccion;
        objetoActualizar.Título = nombreoducmento;
        ActualizarMetadatosDocumento(objetoActualizar)
    });
}

function ActualizarMetadatosDocumento(objetodocuemnto)
{
    var settings = {
        "async": true,
        "crossDomain": true,
        "url": "http://localhost:85/_vti_bin/listdata.svc/DocumentosInfraccion%28" + objetodocuemnto.Identificador + "%29",
        "method": "POST",
        "headers": {
            "accept": "application/json; odata=verbose",
            "content-type": "application/json; odata=verbose",
            "x-requestdigest": "$(\\\"#__REQUESTDIGEST\\\").val()",
            "x-http-method": "MERGE",
            "if-match": "*",
            "cache-control": "no-cache",
            "postman-token": "17a502b0-1084-0b5f-3d26-85f103a4554e"
        },
        "data": "{\"IdInfraccion\": \"" + objetodocuemnto.IdInfraccion + "\",\"Infraccion\": \"" + objetodocuemnto.Infraccion + "\",\"NumeroRadicado\": \"" + objetodocuemnto.NumeroRadicado + "\",\"Título\":\"" + objetodocuemnto.Título + "\"}"
    }

    $.ajax(settings).done(function (response) {
        ConsultarDocumetos(objetodocuemnto.IdInfraccion);
    });
}


function CompletarTarea(idtarea)
{
    var settings = {
        "async": true,
        "crossDomain": true,
        "url": "http://localhost:85/_vti_bin/Lists.asmx?op=UpdateListItems",
        "method": "POST",
        "headers": {
            "content-type": "text/xml; charset=utf-8",
            "content-length": "10000",
            "soapaction": "http://schemas.microsoft.com/sharepoint/soap/UpdateListItems",
            "cache-control": "no-cache"
        },
        "data": "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">\r\n  <soap:Body>\r\n    <UpdateListItems xmlns=\"http://schemas.microsoft.com/sharepoint/soap/\">\r\n      <listName>Tareas</listName>\r\n      <updates><Batch OnError='Continue'><Method ID='1' Cmd='Update'>\r\n        <Field Name='ID'>" + idtarea + "</Field>\\  \r\n         <Field Name='PercentComplete'>1.0</Field> \r\n              </Method> \\</Batch></updates>\r\n    </UpdateListItems>\r\n  </soap:Body>\r\n</soap:Envelope>"
    }

    $.ajax(settings).done(function (response) {
       
    });
}


function CompletarListaTarea(tareasxml)
{
    var jsonTareas = x2js.xml2json(tareasxml)
    jsonTareas.each(function () {
        CompletarTarea(this.Identificador);
    });
}