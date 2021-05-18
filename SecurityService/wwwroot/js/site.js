// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


// Write your JavaScript code.

var swiper = new Swiper('.swiper-container', {
    direction: 'vertical',
    spaceBetween: 5,
    effect: 'fade',
    centeredSlides: true,
    
    autoplay: {
        delay: 10000,
        disableOnInteraction: false,
    },
    pagination: {
        el: '.swiper-pagination',
        clickable: true,
    },
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
    },
});

// search function

$(document).ready(function () {
    var myNav = document.getElementById("myNav");
    var searchAround = document.getElementById("search-around");
    $('#search').click(function () {
        $('.myNav-item').addClass('hide-item');
        $('.search-form').addClass('active');
        $('.close').addClass('active');
        $('#search').hide();
        $('.search-dropdown').addClass('active');
        myNav.style.backgroundColor = "rgba(0,0,0,1)";
        searchAround.style.display = "block";
        document.body.style.overflow = "hidden";
        
        
        
    })
    $('.close').click(function () {
        $('.myNav-item').removeClass('hide-item');
        $('.search-form').removeClass('active');
        $('.close').removeClass('active');
        $('.search-dropdown').removeClass('active');
        $('#search').show();
        myNav.style.removeProperty("background-color");
        searchAround.style.display = "none";
        document.body.style.removeProperty("overflow");
        
    })
})


// navigation sticky

window.onscroll = function () { myFunction() };

var header = document.getElementById("myNav");
var sticky = header.offsetTop;

function myFunction() {
    if (window.pageYOffset > sticky) {
        header.classList.add("sticky");


    } else {
        header.classList.remove("sticky");

    }
};


//hamberger menu

$(document).ready(function () {
    var myNav_list = document.getElementById('myNav-list');
    var myNav = document.getElementById('myNav');
    var navIcon = document.getElementById('nav-icon');
    $('#menu-btn').click(function () {
        if ($(this).prop("checked") == true) {
            myNav_list.classList.add("active");
            myNav.classList.add("active");
            document.body.style.overflow = "hidden";
            navIcon.classList.add("active");
        } else {
            myNav_list.classList.remove("active");
            myNav.classList.remove("active");
            document.body.style.removeProperty("overflow");
            navIcon.classList.remove("active");

        }
    })
})