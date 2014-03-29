$(document).ready(function () {
    PageMethods.GetPanier(function (data) {
        $('#imgWait').hide();

        $(data).each(function (index, item) {
            $('#divReservations').append('<input type="checkbox" data-id="' + item + '" name="checkbox">Match : ' + item
                + '</input><br/>');
        });

    }, function (err) { alert('erreur'); });

    //validation des réservations du panier
    $('#validationButton').click(function () {
        var checked = $('input[type="checkbox"]:checked');
        var listIdChecked = new Array();

        $(checked).each(function (index, item) {
            listIdChecked.push(parseInt(item.getAttribute('data-id').toString()));
        });
    });

    //annulation des réservations sélectionnées
    $('#annulationButton').click(function () {
        var checked = $('input[type="checkbox"]:checked');
        var listIdChecked = new Array();

        $(checked).each(function (index, item) {
            listIdChecked.push(parseInt(item.getAttribute('data-id').toString()));
        });

        PageMethods.CancelReservations(listIdChecked, function (data) { document.location.reload(); });
    });

    //annulation de toutes les réservations
    $("#annulationAllButton").click(function () {
        PageMethods.ClearPanier(function () { location.reload(); });
    });
});