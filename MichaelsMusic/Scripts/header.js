$(document).ready(function () {
    'use strict';

    var $expandBtn = $('.mobile-expand > a'),
        $mainMenuItems = $('.menu li').not('.branding, .mobile-expand'),
        $submenuHeadings = $('.has-submenu > a[href="#"]'),
        $submenus = $('.submenu'),
        animationDefaults = {
            'duration': 50,
            'easing': 'linear'
        };

    // Handle 'Expand' button (only shown on mobile screens)
    $expandBtn.on('click', function (e) {
        e.preventDefault();
        $mainMenuItems.slideToggle(animationDefaults);
    });

    // Show submenu when clicking a menu heading
    $submenuHeadings.on('click', function (e) {
        e.preventDefault();
        $(this).next('.submenu').slideToggle(animationDefaults);
    });

    $('body').on('click', function () {
        if ($('.submenu').is(':visible')) {
            $('.submenu').hide();
        }
    });

    $('.main-header').on('click', function (e) {
        e.stopImmediatePropagation();
    })
});