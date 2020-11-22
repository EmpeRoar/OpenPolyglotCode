$(document).ready(function() {
    console.log('its working!');
    let xpos = 0;


    $('#left').on('click', function(){
        var div = $("div#jbx-carousel");  
        div.animate({left: xpos+=700});
    });
    $('#right').on('click', function(){
        

        var div = $("div#jbx-carousel");  
        div.animate({left: xpos-=700});

       
    });
});
