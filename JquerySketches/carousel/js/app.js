$(document).ready(function() {
    console.log('its working!');
    let xpos = 0;
    let navigator = 0;
    let items = [];

    let itemPointer = 0;
    let leftPointer = 1;
    $('#jbx-carousel').children('.item').map(function() {
        items.push({
            img: $(this).children('img').attr('src'),
            title: $(this).children('div').children('span').html()
        });
    });
    $('#jbx-carousel').html('');

    let html = '';
    items.forEach(element => {
        html += `<div class="item"><img src="${element.img}" /><div><span>${element.title}</span></div></div>`;
    });
    $('#jbx-carousel').html(html);


    $('#left').on('click', function(){
        var div = $("div#jbx-carousel");  

        //$("div#jbx-carousel").width($("div#jbx-carousel").width()-320);
        div.animate({left: xpos+=230});
       
        let html = '';
        items.forEach(element => {
            html += `<div class="item"><img src="${element.img}" /><div><span>${element.title}</span></div></div>`;
        });
        $('#jbx-carousel').html(html);
        
    });
    $('#right').on('click', function(){        
        var div = $("div#jbx-carousel");  

        $("div#jbx-carousel").width($("div#jbx-carousel").width()+320);
        div.animate({left: xpos-=230});
        
        items.push({
            img: items[itemPointer].img,
            title: items[itemPointer].title
        });
        itemPointer++;
        let html = '';
        items.forEach(element => {
            html += `<div class="item"><img src="${element.img}" /><div><span>${element.title}</span></div></div>`;
        });
        $('#jbx-carousel').html(html);

        
    });
});
