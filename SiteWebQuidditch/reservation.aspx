<%@ Page Title="" Language="C#" MasterPageFile="~/SiteQuidditch.Master" AutoEventWireup="true" CodeBehind="reservation.aspx.cs" Inherits="SiteWebQuidditch.reservation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href="Styles/reservation.css" />
    <script src="Javascripts/jquery-1.11.0.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
    <h1 class="Titre">Gestion des réservations</h1>
    <img id="imgWait" src="resources/wait.gif" class="ImgWait" />
    <div id="divReservations"></div>
    <button id="validationButton" type="button">Valider</button>
</asp:Content>
