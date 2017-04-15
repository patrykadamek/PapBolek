<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AkceptujWypozyczenie.aspx.cs" Inherits="WebApplication1.AkceptujWypozyczenie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Tytul" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Tytul" HeaderText="Tytul" ReadOnly="True" SortExpression="Tytul" />
            <asp:BoundField DataField="Autor" HeaderText="Autor" SortExpression="Autor" />
            <asp:BoundField DataField="KtoWypozycza" HeaderText="KtoWypozycza" SortExpression="KtoWypozycza" />
            <asp:BoundField DataField="DoKiedy" HeaderText="DoKiedy" SortExpression="DoKiedy" />
            <asp:ButtonField text="Akceptuj Wypożyczenie" CommandName="Select"/> 
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [DoWypozyczenia]"
        ></asp:SqlDataSource>
</asp:Content>
