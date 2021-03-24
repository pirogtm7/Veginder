// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const gridElement = document.querySelector('.grid');
const filterField = document.querySelector('.grid-control-field.filter-field');
const searchField = document.querySelector('.grid-control-field.search-field');
const sortField = document.querySelector('.grid-control-field.sort-field');
const layoutField = document.querySelector('.grid-control-field.layout-field');
const addButton = document.querySelector('.grid-button.add-more-items');
const itemTemplate = document.querySelector('.grid-item-template');
const characters = 'abcdefghijklmnopqrstuvwxyz';
const colors = ['red', 'blue', 'green'];

let sortFieldValue;
let searchFieldValue;


// Write your JavaScript code.
var dragSortOptions = {
    action: 'swap',
    threshold: 50
};
var grid = new Muuri('.grid', {
    dragEnabled: true,
    
    //sortData: {
    //    foo: function (item, element) {
    //        return parseFloat(element.getAttribute('data-foo'));
    //    }
    //}
});

function initDemo() {
    // Reset field values.
    searchField.value = '';
    [sortField, filterField, layoutField].forEach((field) => {
        field.value = field.querySelectorAll('option')[0].value;
    });

    // Set inital search query, active filter, active sort value and active layout.
    searchFieldValue = searchField.value.toLowerCase();
    sortFieldValue = sortField.value;


    // Search field binding.
    searchField.addEventListener('keyup', function () {
        var newSearch = searchField.value.toLowerCase();
        if (searchFieldValue !== newSearch) {
            searchFieldValue = newSearch;
            filter();
        }
    });

    // Filter, sort and layout bindings.
    filterField.addEventListener('change', filter);
    sortField.addEventListener('change', sort);
    layoutField.addEventListener('change', updateLayout);

    // Add/remove items bindings.
    addButton.addEventListener('click', addItems);
    gridElement.addEventListener('click', (e) => {
        if (e.target.matches('.grid-card-remove')) {
            removeItem(grid.getItem(e.target.closest('.grid-item')));
        }
    });
}
// Refresh sort data whenever an item's data-foo or data-bar changes
grid.refreshSortData();

grid.filter('[foo]');

//If compareFunction(a, b) returns less than 0, leave a and b unchanged.
//If compareFunction(a, b) returns 0, leave a and b unchanged with respect to each other, but sorted with respect to all different elements.Note: the ECMAScript standard only started guaranteeing this behavior in 2019, thus, older browsers may not respect this.
//If compareFunction(a, b) returns greater than 0, sort b before a.
grid.sort(function (itemA, itemB) {
    var aId = parseInt(itemA.getElement().getAttribute('data-shop'));
    var bId = parseInt(itemB.getElement().getAttribute('data-shop'));

    return bId - aId;
});

function filter(onFinish = null) {
    const filterFieldValue = filterField.value;
    grid.filter(
        (item) => {
            const element = item.getElement();
            const isSearchMatch =
                !searchFieldValue ||
                (element.getAttribute('data-title') || '').toLowerCase().indexOf(searchFieldValue) > -1;
            const isFilterMatch =
                !filterFieldValue || filterFieldValue === element.getAttribute('data-color');
            return isSearchMatch && isFilterMatch;
        },
        { onFinish: onFinish }
    );

}

function sort() {
    var currentSort = sortField.value;
    if (sortFieldValue === currentSort) return;

    // Sort the items.
    grid.sort(
        currentSort === 'title' ? 'title' : currentSort === 'color' ? 'color title' : dragOrder
    );

    // Update active sort value.
    sortFieldValue = currentSort;
}


initDemo();