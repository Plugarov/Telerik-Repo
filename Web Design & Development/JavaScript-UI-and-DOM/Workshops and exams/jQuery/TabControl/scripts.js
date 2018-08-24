$.fn.tabs = function () {

    $('#tabs-container').addClass('tabs-container');
    var tabs = $('.tab-item');

    tabs.on('click', function () {
        tabs.children('.tab-item-content').hide();
        tabs.removeClass('current');
        $(this).find('.tab-item-content').show();
        $(this).addClass('current');
    });

    tabs.first().click();
};