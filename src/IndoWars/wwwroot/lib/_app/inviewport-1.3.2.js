!function(e){e.fn.viewportChecker=function(t){var n={classToAdd:"visible",offset:100,callbackFunction:function(e){}};e.extend(n,t);var i=this,s=e(window).height();this.checkElements=function(){var t=navigator.userAgent.toLowerCase().indexOf("webkit")!=-1?"body":"html",o=e(t).scrollTop(),c=o+s;i.each(function(){var t=e(this);if(!t.hasClass(n.classToAdd)){var i=Math.round(t.offset().top)+n.offset,s=i+t.height();i<c&&s>o&&(t.addClass(n.classToAdd),n.callbackFunction(t))}})},e(window).scroll(this.checkElements),this.checkElements(),e(window).resize(function(e){s=e.currentTarget.innerHeight})}}(jQuery);