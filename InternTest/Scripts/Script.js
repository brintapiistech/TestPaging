
function pageid(url) {
    $.ajax({
        type: 'GET',
        url: url,
        success: function (res) {
            console.log(res);
            $("#testPage").html(res);
        }
    })

}

