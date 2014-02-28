$(document).ready(function () {
    PageMethods.GetAllMatchs(function (data) {
        $('#imgWait').hide();
        $(data).each(function (index, item) {
            $('#divMatchs').append('<div>Coupe : ' + item.Id
                + ' Date : ' + item.Date
                + ' Domicile : ' + item.EquipeDomicileId
                + ' Visiteur : ' + item.EquipeVisiteurId
                + ' Stade : ' + item.StadeId
                + '</div>');
        });

    }, function (err) { alert('erreur'); } );
});