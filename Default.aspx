<%@ Page Title="" Language="C#" MasterPageFile="~/src/html/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="src_html_Default" %>

<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <form id="form1" runat="server">
    Select St Date<br />
    <asp:TextBox ID="txtstar" runat="server" Width="277px"></asp:TextBox>
    <asp:ImageButton ID="ImageButton1" runat="server" Height="39px" 
        ImageUrl="~/src/assets/images/logos/pngegg.png" onclick="ImageButton1_Click" 
        Width="38px" />
    <br />
    <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" 
        BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
        Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" 
        onselectionchanged="Calendar1_SelectionChanged" ShowGridLines="True" 
        Visible="False" Width="220px">
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <SelectorStyle BackColor="#FFCC66" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
            ForeColor="#FFFFCC" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
    </asp:Calendar>
    <p>
    </p>
    </form>
</asp:Content>


