(function(global, $) {
    'use strict';
    var $expandBtn = $('.mobile-expand'),
        $topLevelMenuItems = $('.menu li').not('.submenu li');

    $('body').on('click', $expandBtn, function(e) {
        e.preventDefault();
        var $this = $(this);
        $topLevelMenuItems.slideDown();
    });
})(window, jQuery);