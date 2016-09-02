$(document).ready(function () {
    'use strict';

    var MEDIUM_BREAKPOINT = 640,
        windowWidth = $(window).width(),
        maxHeight = 0,
        $items;

    if (windowWidth >= MEDIUM_BREAKPOINT) {
        $items = $('.item-collection > li');

        $.each($items, function () {
            var height = $(this).height();
            maxHeight = height > maxHeight ? height : maxHeight;
        });

        $.each($items, function () {
            $(this).css('height', maxHeight);
        });
    }
});