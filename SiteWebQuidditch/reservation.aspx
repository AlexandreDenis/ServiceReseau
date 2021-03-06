﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SiteQuidditch.Master" AutoEventWireup="true" CodeBehind="reservation.aspx.cs" Inherits="SiteWebQuidditch.reservation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href="Styles/reservation.css" />
    <script src="Javascripts/reservation.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
    <h1 class="Titre">Gestion des réservations</h1>
    <h3>Votre panier :</h3>
    <img id="imgWait" src="resources/wait.gif" class="ImgWait" />
    <div id="divReservations"></div>
    <button id="validationButton" type="button">Valider</button>
    <button id="annulationButton" type="button">Annuler</button>
    <button id="annulationAllButton" type="button">Annuler toutes les commandes</button>
</asp:Content>
