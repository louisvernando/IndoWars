!function(n){var t=n(window),i=t.height();t.resize(function(){i=t.height()}),n.fn.parallax=function(o,e,u){function r(){var u=t.scrollTop();c.each(function(){var t=n(this),r=t.offset().top,a=h(t);r+a<u||r>u+i||(adjustit=-100,c.css("backgroundPosition",o+" "+Math.round((l-u)*e)+adjustit+"px"))})}var h,l,c=n(this);c.each(function(){l=c.offset().top}),h=u?function(n){return n.outerHeight(!0)}:function(n){return n.height()},(arguments.length<1||null===o)&&(o="50%"),(arguments.length<2||null===e)&&(e=.1),(arguments.length<3||null===u)&&(u=!0),t.bind("scroll",r).resize(r),r()}}(jQuery);