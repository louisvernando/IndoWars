//Contoh agar sebuah Variable tidak menjadi global scope dan langsung dijalankan saat site.js di gunakan
(function () {
    //var ele = $("#username");
    //ele.text("Louis");

    var $sidebarAndWrapper = $("#sidebar, #wrapper");
    var $sidebarIcon = $("#sidebarToggle, i.fa");

    $("#sidebarToggle").on("click", function () {
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            $sidebarIcon.removeClass("fa-chevron-left");
            $sidebarIcon.addClass("fa-chevron-right");
        }
        else {
            $sidebarIcon.addClass("fa-chevron-left");
            $sidebarIcon.removeClass("fa-chevron-right");
        }
    });

    var $sidebarNavHome = $("#sidebarNavHome");
    var $sidebarNavChapter = $("sidebarNavChapter");
    var $sidebarNavLogin = $("sidebarNavLogin");

    $("sidebarNavHome").onclick = function() { toggleSidebarNavActive(1) };
    $("sidebarNavChapter").onclick = function () { toggleSidebarNavActive(2) };
    $("sidebarNavLogin").onclick = function () { toggleSidebarNavActive(3) };

    function toggleSidebarNavActive(navId) {
        switch (navId) {
            case 1:
                $sidebarNavHome.addClass("active");
                $sidebarNavLogin.removeClass("active");
                $sidebarNavChapter.removeClass("active");
                break;
            
            case 2:
                $sidebarNavHome.removeClass("active");
                $sidebarNavLogin.removeClass("active");
                $sidebarNavChapter.addClass("active");
                break;

            case 3:
                $sidebarNavChapter.removeClass("active");
                $sidebarNavLogin.addClass("active");
                $sidebarNavChapter.removeClass("active");
                break;

            default:
                break;
        }
    }

})();
