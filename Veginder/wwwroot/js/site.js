// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var dragSortOptions = {
    action: 'swap',
    threshold: 50
};
var grid = new Muuri('.grid', {
    dragEnabled: false,
    
    //sortData: {
    //    foo: function (item, element) {
    //        return parseFloat(element.getAttribute('data-foo'));
    //    }
    //}
});
// Refresh sort data whenever an item's data-foo or data-bar changes
grid.refreshSortData();

grid.filter('[foo]');

//If compareFunction(a, b) returns less than 0, leave a and b unchanged.
//If compareFunction(a, b) returns 0, leave a and b unchanged with respect to each other, but sorted with respect to all different elements.Note: the ECMAScript standard only started guaranteeing this behavior in 2019, thus, older browsers may not respect this.
//If compareFunction(a, b) returns greater than 0, sort b before a.
grid.sort(function (itemA, itemB) {
    var aId = parseInt(itemA.getElement().getAttribute('data-foo'));
    var bId = parseInt(itemB.getElement().getAttribute('data-foo'));
    if (bId < aId) {
        return true;
    }
    return false;
    return bId - aId;
});
