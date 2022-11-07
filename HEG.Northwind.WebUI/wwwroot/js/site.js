// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var Site = {
    Ajax: function (_url, _data, _method, success, _contentType) {
        if (_contentType == undefined) {
            _contentType = "application/x-www-form-urlencoded"
            //_contentType = "application/x-www-form-urlencoded"
        }

        $.ajax({
            type: _method,
            url: _url,
            dataType: 'json',
            contentType: _contentType,
            data: _data,
            //async: true
        })
            .done(function (result) {
                if (result == "SessionTimeout") {
                    window.location.href = window.location.origin + '/Account/Login'
                    return;
                } else {
                    success(result);
                }
            })
            .fail(function (xhr, textStatus, errorThrow) {
            });
    }
}