<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BusDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" Width="186px" DataSourceID="SqlDataSource1" DataTextField="BoardingPoint" DataValueField="BoardingPoint" CausesValidation="True">


            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BusDbConnectionString2 %>" SelectCommand="SELECT [BoardingPoint] FROM [BusInfo]"></asp:SqlDataSource>
            &nbsp;&nbsp;
            <br />
            <br />
            BOARDING POINT<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; TRAVEL DATE<br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; AMOUNT<br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; RATING<br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Save Bus Data" Width="152px" />
            <br />
        </div>
    </form>
</body>
</html>
