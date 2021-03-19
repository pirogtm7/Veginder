// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var dragSortOptions = {
    action: 'swap',
    threshold: 50
};
var grid = new Muuri('.grid', {
    dragEnabled: true,
    dragStartPredicate: function (item, event) {
        // Prevent first item from being dragged. 
        if (grid.getItems().indexOf(item) === 0) {
            return false;
        }
        // For other items use the default drag start predicate.
        return Muuri.ItemDrag.defaultStartPredicate(item, event);
    },
    dragSortPredicate: function (item) {
        var result = Muuri.ItemDrag.defaultSortPredicate(item, dragSortOptions);
        return result && result.index === 0 ? false : result;
    }
});