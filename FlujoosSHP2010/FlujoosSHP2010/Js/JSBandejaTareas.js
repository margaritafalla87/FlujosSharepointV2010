function ConsultarTareas() {
    var userid = 715;//_spUserId;
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
            "postman-token": "a7f85b0b-47d5-02a9-2344-ce28afe0139b"
        },
        "data": "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">\r\n  <soap:Body>\r\n    <GetListItems xmlns=\"http://schemas.microsoft.com/sharepoint/soap/\">\r\n      <listName>Tareas</listName>\r\n      <query><Query><Where><And><Neq><FieldRef Name='PercentComplete' /><Value Type='Number'>1.0</Value></Neq><Eq><FieldRef Name='AssignedTo' LookupId='True' /><Value Type='Integer'>" + userid.toString() + "</Value></Eq></And></Where></Query></query>\r\n    </GetListItems>\r\n  </soap:Body>\r\n</soap:Envelope>"
    }

    $.ajax(settings).done(function (response) {
        var x2js = new X2JS()
        var jsonTareas = x2js.xml2json(response)
       
        var lenghtTareas = jsonTareas.Envelope.Body.GetListItemsResponse.GetListItemsResult.listitems.data._ItemCount;
            
            if (lenghtTareas > 0 )
            {
                var tareasa = jsonTareas.Envelope.Body.GetListItemsResponse.GetListItemsResult.listitems.data.row;
                if (lenghtTareas != 1) {
                    InsertarTablaTareas(tareasa);
                }
                else {
                    InsertarTablaTarea(tareasa);
                }                
            }
    });

    function FiltarTareas(resultados, idinfraccion) {
        return $.grep(resultados, function (n) {
            return (n.ContenidoRelacionado.indexOf('ID=' + idinfraccion + ',') > -1);
        });
    }

    function InsertarTablaTareas(tareaa) {
        $("#tareas").empty();
        var markup = "<tr><td></td><td>Tarea</td><td>Nombre de Tarea</td></tr>";
        jQuery.each(tareaa, function (index, item) {
            markup += "<tr><td></td><td>" + item._ows_Title + "</td><td>" + item._ows_Created + "</td></tr>";
        });
        $("#tareas").append(markup);
    }

    function InsertarTablaTarea(item) {
        $("#tareas").empty();
        var markup = "<tr><td></td><td>Tarea</td><td>Nombre de Tarea</td></tr>";
        markup += "<tr><td></td><td>" + item._ows_Title + "</td><td>" + item._ows_Created + "</td></tr>";
        $("#tareas").append(markup);
    }

    function ConsultarInfracciones()
    {
        var settings = {
            "async": true,
            "crossDomain": true,
            "url": "http://localhost:85/_vti_bin/ListData.svc/ListaInfracciones",
            "method": "GET",
            "headers": {
                "accept": "application/json",
                "content-type": "application/json",
                "cache-control": "no-cache"
            }
        }

        $.ajax(settings).done(function (response) {
           
        });
    }

    var extended = {};

    // Merge the object into the extended object
    var merge = function (obj) {
        if (obj.hasOwnProperty(prop)) {
            // Push each value from `obj` into `extended`
            extended[prop] = obj[prop];
        }
    };
}


