<%@ Page Title="" Language="C#" MasterPageFile="~/SiteQuidditch.Master" AutoEventWireup="true" CodeBehind="matchs.aspx.cs" Inherits="SiteWebQuidditch.matchs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href="Styles/matchs.css" />
    <script src="Javascripts/matchs.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
    <h1 class="Titre">Gestion des matchs</h1>
    <img id="imgWait" src="resources/wait.gif" class="ImgWait" />
    <div id="divMatchs"></div>
</asp:Content>
