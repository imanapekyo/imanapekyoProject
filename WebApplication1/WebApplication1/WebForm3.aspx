﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
        	first name :&nbsp;
			<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
			<br />
			last name :
			<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
			<br />
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" ></asp:Button>
        </div>
    </form>
</body>
</html>
