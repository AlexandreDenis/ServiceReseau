$(document).ready(function () {
    PageMethods.GetAllMatchs(function (data) {
        $('#imgWait').hide();
        $(data).each(function (index, item) {
            $('#divMatchs').append('<input type="checkbox" data-id="' + item.Id + '" name="checkbox">Match : ' + item.Id
                + ' Date : ' + item.Date
                + ' Domicile : ' + item.EquipeDomicileId
                + ' Visiteur : ' + item.EquipeVisiteurId
                + ' Stade : ' + item.StadeId
                + '</input><br/>');
        });

    }, function (err) { alert('erreur'); });

    $("#reservationButton").click(function () {
        var checked = $('input[type="checkbox"]:checked');
        var listId = new Array();

        $(checked).each(function (index, element)
        {
            listId.push(element.getAttribute('data-id'));
        });

        alert(listId);

        PageMethods.SetReservations(listId, function (data) { document.location.href = "reservation.aspx"; });
    });

}); 