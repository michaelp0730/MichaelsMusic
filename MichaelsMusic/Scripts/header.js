(function(global, $) {
    'use strict';
    var $expandBtn = $('.mobile-expand'),
        $topLevelMenuItems = $('.menu li').not('.submenu li, .branding, .mobile-expand');

    $('body').on('click', $expandBtn, function(e) {
        e.preventDefault();
        var $this = $(this);
        $topLevelMenuItems.slideToggle({
            'duration': 50,
            'easing': 'linear'
        });
    });
})(window, jQuery);