$(document).ready(function () {
    PageMethods.GetAllMatchs(function (data) {
        $('#imgWait').hide();
        $(data).each(function (index, item) {
            date = new Date(item.Date);
            $('#divMatchs').append('<input type="checkbox" data-id="' + item.Id + '" name="checkbox">Match : ' + item.Id
                + ' | Date : ' + date.toLocaleString()
                + ' | Domicile : ' + item.EquipeDomicileId
                + ' | Visiteur : ' + item.EquipeVisiteurId
                + ' | Stade : ' + item.StadeId
                + '</input><br/>');
        });

    }, function (err) { alert('erreur'); });

    //appui sur le bouton de réservation
    $("#reservationButton").click(function () {
        var checked = $('input[type="checkbox"]:checked');
        var listId = new Array();

        $(checked).each(function (index, element)
        {
            listId.push(element.getAttribute('data-id'));
        });

        PageMethods.SetReservations(listId, function (data) { document.location.href = "reservation.aspx"; });
    });

}); 