<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl1.ascx.cs" Inherits="FlujoosSHP2010.ControlTemplates.FlujoosSHP2010.UserControl1" %>
 <script type="text/javascript" src="/js/jquerymin.js"></script>
<script type="text/javascript" src="/js/JsPageUserControl.js"></script>
<script type="text/javascript" src="/js/xml2json.min.js"></script>
<script type="text/javascript" src="/js/jquery.SPServices.min.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        ConsultarListaInfraccion();
    }
    );
</script>
 
<label id="tituloinfraccion"></label>
<label id="radicado"></label>
<label id="descarioninfraccion"></label>
<label id="fecharadicado"></label>
<table width="100%" id="resultados">
    <thead>
            <tr>
                <th>Select</th>
                <th>Name</th>
                <th>Email</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td width="15%">
                   Nombre
                </td>
                <td width="5%">
                    Radicado
                </td>
                <td width="80%">
                    ID
                </td>
            </tr>
            <tbody>
</table>
<label id="idinfraccion" style="display: none"></label>
<button type="button" onclick="Generardocumento();"> Crear Documento</button>
<button type="button" onclick="CompletarTarea();"> Aprobar</button>
<script type="text/javascript" src="/js/JsPageUserControl.js"></script>