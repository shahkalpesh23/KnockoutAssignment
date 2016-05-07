
window.$post = function (url, input, callback) {
    $.ajax({
        async: true,
        type: "POST",
        url: url,
        data: JSON.stringify(input),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: callback
    });
};

LoadCompletePageData = function (input, callback) {
    $post("/WebService/LoadInformationService.asmx/LoadCompletePageData", input, callback);
};

AuthenticateUser = function (input, callback) {
    $post("/WebService/LoadInformationService.asmx/AuthenticateUser", input, callback);
};

ChangeNewsVisibility = function (input, callback) {
    $post("/WebService/LoadInformationService.asmx/ChangeNewsVisibility", input, callback);
};

LogOut = function (input, callback) {
    $post("/WebService/LoadInformationService.asmx/Logout", input, callback);
};