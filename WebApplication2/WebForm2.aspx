<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 237px">
            WELCOME TO DERMA DARAH BY APEKYO CO.<br />
            <br />
            NAME:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="jgn lupa masuk nama laaa"></asp:RequiredFieldValidator>
            <br />
            IC. NO :
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="no sahaja la woi" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
            <br />
            <br />
            <fieldset style "width :300px">
            <legend> <b>BLOOD GROUP</b></legend>
            <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="O" GroupName="group" />
            <asp:RadioButton ID="RadioButton2" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" Text="B" GroupName="group" />
            <asp:RadioButton ID="RadioButton3" runat="server" OnCheckedChanged="RadioButton3_CheckedChanged" Text="A" GroupName="group" />
            <asp:RadioButton ID="RadioButton4" runat="server" OnCheckedChanged="RadioButton4_CheckedChanged" Text="AB" GroupName="group" />
            </fieldset><br />
             <fieldset style "width :300px">
            <legend> <b>gender</b></legend>
                 <asp:CheckBoxList ID="CheckBoxList1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
                     <asp:ListItem>male</asp:ListItem>
                     <asp:ListItem>female</asp:ListItem>
                     <asp:ListItem>power</asp:ListItem>
                 </asp:CheckBoxList>
            </fieldset><br />
            <br />
&nbsp;<br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SUMBIT" />
    </form>
</body>
</html>