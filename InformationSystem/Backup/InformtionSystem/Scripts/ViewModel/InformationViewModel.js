/// <reference path="../jquery-1.9.1.js" />
/// <reference path="../knockout-2.2.1.js" />
/// <reference path="../API/API.js" />

function Post(data, isAdmin) {
    var self = this;
    self.LogId = data.LogId;
    self.Title = data.Title;
    self.Description = data.Description;
    self.PublishDate = data.PublishDate;
    self.Categary = data.Categary;
    self.Show = isAdmin ? true : data.Show;
    self.displayNews = ko.observable(data.Show);

    self.displayNews.subscribe(function (flagValue) {
        ChangeNewsVisibility({ id: self.LogId, showFlag: flagValue }, {});
    });

    return self;
}


function LoadPostData(data, isAdmin) {
    var self = this;

    self.IsAdmin = isAdmin;
    self.Role = isAdmin ? "Welcome Admin !!" : "Welcome User !!";
    self.inlitializeData = [];

    $.each(data.DataList, function (a, item) {
        self.inlitializeData.push(new Post(item, isAdmin));
    });

    self.chosenCategory = ko.observable("All");
    self.informationCategory = ['All', 'Sports', 'News'];

    self.postList = ko.computed(function () {
        if (self.chosenCategory() === "All") {
            return self.inlitializeData;
        }
        return ko.utils.arrayFilter(self.inlitializeData, function (item) {
            return (item.Categary === self.chosenCategory());
        });
    });
}