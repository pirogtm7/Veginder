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

grid.sort(function (itemA, itemB) {
    var aId = parseInt(itemA.getElement().getAttribute('data-foo'));
    var bId = parseInt(itemB.getElement().getAttribute('data-foo'));
    return bId - aId;
});
