<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		#form1 {
			height: 77px;
		}
	</style>
</head>
<body style="height: 122px">
    <form id="form1" runat="server">
        <div>
        	<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    	<asp:CheckBoxList ID="CheckBoxList1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
			<asp:ListItem Text ="Bowling">Bowling </asp:ListItem>
			<asp:ListItem Text ="Swimming">Swimming </asp:ListItem>
			<asp:ListItem Text ="Driving while texting ">driving while texting </asp:ListItem>
		</asp:CheckBoxList>
    </form>
</body>
</html>
