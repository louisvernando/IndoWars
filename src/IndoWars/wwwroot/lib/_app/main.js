jQuery(function(e){"use strict";function a(){e("#c_name").hasClass("green")&&e("#c_phone").hasClass("green")&&e("#c_email").hasClass("green")&&e("#c_message").hasClass("green")?(e("#c_send").removeClass("disabled"),console.log("enabled")):(e("#c_send").addClass("disabled"),console.log("disabled"))}var n=window.CALIBER_SETTINGS||{};n.galleryFiltering=function(){e.isFunction(e.fn.mixItUp)&&e("#gallery-mixitup").mixItUp({animation:{duration:480,effects:"fade translateX(10%) scale(0.25) stagger(58ms)",easing:"ease"},selectors:{target:".filter-item",filter:".filter-mixitup .filter"}})},n.fancyBox=function(){e.isFunction(e.fn.fancybox)&&e(".fancybox").fancybox()},n.parallaxScrolling=function(){e.isFunction(e.fn.localScroll)&&(e("#parallax-nav-primary").localScroll(800),e("#parallax-nav-dark").localScroll(800),e("#parallax-mobile-menu").localScroll(800)),e.isFunction(e.fn.parallax)&&(e("#header").parallax("50%",.1),e("#about").parallax("50%",.1),e("#team").parallax("50%",.1),e("#services").parallax("50%",.1),e("#capabilities").parallax("50%",.1),e("#portfolio").parallax("50%",.1),e("#blog").parallax("50%",.1),e("#contact").parallax("50%",.1))},n.fixedParallaxHeader=function(){e.isFunction(e.fn.parallax)&&(e(window).scrollTop()>=50?e(".header-parallax").addClass("fixed-top"):e(".header-parallax").removeClass("fixed-top"))},n.twitterCarousel=function(){e.isFunction(e.fn.owlCarousel)&&e("#twitter-carousel").owlCarousel({autoPlay:3e3,stopOnHover:!0,navigation:!0,pagination:!1,navigationText:["<i class='mdi mdi-chevron-left'>","<i class='mdi mdi-chevron-right'>"],paginationSpeed:1e3,goToFirstSpeed:2e3,singleItem:!0,autoHeight:!0,transitionStyle:"fade"})},n.imageCarousel=function(){e.isFunction(e.fn.owlCarousel)&&e("#image-slider").owlCarousel({autoPlay:5e3,stopOnHover:!0,navigation:!1,pagination:!0,paginationSpeed:1e3,goToFirstSpeed:2e3,singleItem:!0,autoHeight:!0,lazyLoad:!0,transitionStyle:"fade"})},n.headerSliderCarousel=function(){e.isFunction(e.fn.owlCarousel)&&e("#header-slider").owlCarousel({autoPlay:5e3,stopOnHover:!0,navigation:!0,navigationText:["<i class='mdi mdi-chevron-left'>","<i class='mdi mdi-chevron-right'>"],pagination:!1,paginationSpeed:1e3,goToFirstSpeed:2e3,singleItem:!0,lazyLoad:!0,autoHeight:!0,transitionStyle:"fade"})},n.inViewPortAnimation=function(){e.isFunction(e.fn.viewportChecker)&&e(".inviewport").addClass("hiddenthis").viewportChecker({classToAdd:"visiblethis",offset:0,callbackFunction:function(a){var n=e(a).attr("data-effect");e(a).addClass(n)}})},n.mobileMenu=function(){var a="";e(".menu-ul").each(function(){a+=e(this).html()}),e(".menu-mobile ul.menu").html(a),e(".menu-toggle").on("click",function(){e(".menu-mobile.cssmenu").toggleClass("open"),e(this).toggleClass("mdi-menu mdi-close")}),e(".menu-mobile.cssmenu li.has-sub a").on("click",function(a){e(this).parent().children("ul").toggleClass("open"),e(this).find("i").toggleClass("open"),a.stopPropagation()})},n.validateContactForm=function(){e("#c_name").keyup(function(){var n=e("#c_name").val();null==n||""==n?(e("#c_name").removeClass("green"),console.log(n+"name err")):(e("#c_name").addClass("green"),console.log("name done")),a()}),e("#c_email").keyup(function(){var n=e("#c_email").val(),o=n.indexOf("@"),l=n.lastIndexOf(".");null==n||""==n||o<1||l<o+2||l+2>=n.length?(e("#c_email").removeClass("green"),console.log("email err")):(e("#c_email").addClass("green"),console.log("email done")),a()}),e("#c_phone").keyup(function(){var n=e("#c_phone").val(),o=/^[\d\.\-]+$/;null==n||""==n||n.length<10||!o.test(n)?(e("#c_phone").removeClass("green"),console.log("phone err")):(e("#c_phone").addClass("green"),console.log("phone done")),a()}),e("#c_message").keyup(function(){var n=e("#c_message").val();null==n||""==n||n.length<9?(e("#c_message").removeClass("green"),console.log("message err")):(e("#c_message").addClass("green"),console.log("message done")),a()})},n.sendMessageAJAX=function(){e("#c_send").on("click",function(){if(!e(this).hasClass("disabled")){var a,n=e("#c_email").val(),o=e("#c_name").val(),l=e("#c_phone").val(),t=e("#c_message").val();return a=window.XMLHttpRequest?new XMLHttpRequest:new ActiveXObject("Microsoft.XMLHTTP"),a.onreadystatechange=function(){1==a.readyState&&e("#response_email").html("Sending..."),4==a.readyState&&200==a.status&&e("#response_email").html(a.responseText)},a.open("POST","maintainemail.php",!0),a.setRequestHeader("Content-type","application/x-www-form-urlencoded"),a.send("email="+encodeURIComponent(n)+"&name="+encodeURIComponent(o)+"&phone="+encodeURIComponent(l)+"&msg="+encodeURIComponent(t)),!1}e("#response_email").html("Please Fill in your details correctly and try again")})},n.isotopeMasonaryGallery=function(){if(e.isFunction(e.fn.isotope)){var a=e("#gallery-isotope");a.isotope({filter:"*",layoutMode:"sloppyMasonry",animationOptions:{duration:750,easing:"linear",queue:!1}}),e(".filter-isotope .filter").click(function(){e(".filter-isotope .filter.active").removeClass("active"),e(this).addClass("active");var n=e(this).attr("data-filter");return a.isotope({filter:n,layoutMode:"sloppyMasonry",animationOptions:{duration:750,easing:"linear",queue:!1}}),!1})}},n.settingsPanel=function(){e(".settings-panel .toggle").on("click",function(){e(".settings-panel").toggleClass("collapsed"),e(this).toggleClass("mdi-settings mdi-close")}),e(".settings-panel .style div").on("click",function(){var a=e(this).attr("data-sections");e("#settings-response").load("settings.php",{sections:a}),window.location.reload()}),e(".settings-panel .colors div").on("click",function(){var a=e(this).attr("data-color"),n="";n="yellow"==a?"":"."+a,e("#main-style").attr("href","css/style"+n+".css"),e(".settings-panel .colors div").removeClass("active"),e(this).addClass("active"),e("#settings-response").load("settings.php",{color:a}),e(".style-dependent").each(function(){var n=e(this).attr("src"),o=n;n=n.replace("yellow",a),n=n.replace("red",a),n=n.replace("orange",a),n=n.replace("blue",a),n=n.replace("green",a),n!=o&&e(this).attr("src",n)})})},e(document).ready(function(){n.galleryFiltering(),n.twitterCarousel(),n.imageCarousel(),n.headerSliderCarousel(),n.inViewPortAnimation(),n.mobileMenu(),n.validateContactForm(),n.sendMessageAJAX(),n.fancyBox(),n.parallaxScrolling(),n.settingsPanel()}),e(window).scroll(function(){n.fixedParallaxHeader()}),e(window).resize(function(){}),e(window).load(function(){n.isotopeMasonaryGallery()})});