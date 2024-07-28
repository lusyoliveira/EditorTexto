<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs" Inherits="WebUserControl" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>
 <%@ Register Namespace="MyControls" TagPrefix="custom" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<script src="imce/js/imce.js" type="text/javascript"></script>
<script src="imce/js/imce_set_inline.js" type="text/javascript"></script>
<script src="imce/js/imce_extras.js" type="text/javascript"></script>
<script src="imce/js/imce_set_app.js" type="text/javascript"></script>

<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>

 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
 <custom:CustomEditor ID="cEditor" Width="670px" Height="600px" 
    runat="server" />

    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Salvar" 
        Width="49px" />
    &nbsp;<asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        Text="Consultar" />
&nbsp;<asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
        Text="Atualizar" />
&nbsp;<asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
        Text="Excluir" />

<script language="javascript" type="text/javascript">
    function preview() {         field = document.getElementById( 'upload' ).value;         
    image = document.getElementById( 'previewIMG' );         
    path = 'file://'+ field;         
    path = path.replace(/\\/, '/');         
    image.src = path;         
    image.style.display = 'block';         
    //alert(image.width +"-"+ image.height);         
    if(image.width > image.heigth)         {                
    //paisagem                
     image.style.width = "100px";               
     image.style.height = "75px";         
     }         else         {
     //retrato           
     image.style.width = "75px";
     image.style.height = "100px";
 }
      }

    function show() {

        document.getElementById("<%=dv.ClientID%>").style.display = '';
        document.getElementById("<%=FileUploadControl.ClientID%>").style.display = '';
        document.getElementById("<%=btnUpload.ClientID%>").style.display = '';
        document.getElementById("<%=btnCancel.ClientID%>").style.display = '';
        showFloatDiv();
        //var obj = cEditor.Content;
        //obj.value = 'Aperte aqui!';
        //obj.style.position = 'absolute';
        //area.appendChild(obj);

    }

    function hide() {

        document.getElementById("<%=dv.ClientID%>").style.display = "none";

        document.getElementById("<%=FileUploadControl.ClientID%>").style.display = "none";

        document.getElementById("<%=btnUpload.ClientID%>").style.display = "none";

        document.getElementById("<%=btnCancel.ClientID%>").style.display = "none";

    }

    function showFloatDiv() {



        if (!e) {

            var e = window.event || arguments.callee.caller.arguments[0];

        }

        var scrolledV = scrollV();

        var scrolledH = (navigator.appName == 'Netscape') ? document.body.scrollLeft : document.body.scrollLeft;

        tempX = (navigator.appName == 'Netscape') ? e.clientX : event.clientX;

        tempY = (navigator.appName == 'Netscape') ? e.clientY : event.clientY;

        document.getElementById("<%=dv.ClientID%>").style.left = (tempX + scrolledH) + 'px';

        document.getElementById("<%=dv.ClientID%>").style.top = (tempY + scrolledV) + 'px';

        document.getElementById("<%=dv.ClientID%>").style.display = "";

    }

    function scrollV() {

        var scrolledV;

        if (window.pageYOffset) {

            scrolledV = window.pageYOffset;

        }

        else if (document.documentElement && document.documentElement.scrollTop) {

            scrolledV = document.documentElement.scrollTop;

        }

        else if (document.body) {

            scrolledV = document.body.scrollTop;

        }

        return scrolledV;

    }

</script>

 <div id="dv" style="position: absolute; background-color: Gray; padding: 10px; display: none;"

    runat="server">

    <asp:AsyncFileUpload ID="FileUploadControl" runat="server" Style="display: none"

        Width="300px" />

    <asp:Button ID="btnUpload" runat="server" Text="Upload" Style="display: none" OnClick="btnUpload_Click" />

    <asp:Button ID="btnCancel" runat="server" Text="Cancel" Style="display: none" OnClientClick="hide();" />

</div>
