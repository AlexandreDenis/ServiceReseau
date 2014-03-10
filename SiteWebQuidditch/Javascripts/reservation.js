$(document).ready(function () {
    PageMethods.GetPanier(function (data) {
        $('#imgWait').hide();
        var listId = new Array();
        $(data).each(function (index, item) {
            listId.push(item);
        });

        alert(listId);

    }, function (err) { alert('erreur'); });
});