(function(global, $) {
    'use strict';
    var $expandBtn = $('.mobile-expand > a'),
        $mainMenuItems = $('.menu li').not('.branding, .mobile-expand'),
        mobileAnimationDefaults = {
            'duration': 50,
            'easing': 'linear'
        };

    // Handle 'Expand' button (only shown on mobile screens)
    $expandBtn.on('click', function (e) {
        e.preventDefault();
        $mainMenuItems.slideToggle(mobileAnimationDefaults);
    });

})(window, jQuery);