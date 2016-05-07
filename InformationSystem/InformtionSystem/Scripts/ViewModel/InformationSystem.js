
$("#btnLogon").click(function () {
    var userName = $("#txtUserName").val();
    var password = $("#txtPassword").val();

    if (userName != "" && password != "") {
        AuthenticateUser({ userName: userName, password: password }, function (newsData) {
            if (newsData.d) {
                LoadCompletePageData({}, function (newsData) {
                    var vm = new LoadPostData(newsData.d, true);
                    ko.applyBindings(vm);
                    Clear();
                });
            }
            else {
                alert("Admin Login Failed");
                Clear();
            }
        });
    }
    else {
        alert("Enter correct UserName & Password");
        Clear();
    }
});

$("#btnLogout").click(function () {
    LogOut({}, function () {
        LoadCompletePageData({}, function (newsData) {
            var vm = new LoadPostData(newsData.d, false);
            ko.applyBindings(vm);
        });
    });
});


function Clear() {
    $("#txtUserName").val(null);
    $("#txtPassword").val(null);
}