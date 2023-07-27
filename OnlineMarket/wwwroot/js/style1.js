$('#mybtn').on("click", function () {
    $('html body').toggleClass("lock");
    $('#secondbtn1').addClass("click");
    $('.sidebar').toggleClass("show");
    let button = document.getElementById('secondbtn1'); // Получаем элементы по тегу button берём из них первый(Так же можно получать по классам, по id и так далее)
    let coord = button.getBoundingClientRect(); // Получаем координаты элемента
    let x = coord.x; // Координаты по оси x
    let y = coord.y; // Координаты по оси y
    let width = coord.width; // Получаем ширину элемента
    let height = coord.height;
    button.style.left = '300px';
    var $overlay = $('.overlay'),
        openClass = 'is-open';
    $overlay.addClass(openClass);
});
//$('#Catbtn_1').on("mouseenter", function () {
    
//    $('#2').addClass("show");
//    let button = document.getElementById('secondbtn1'); // Получаем элементы по тегу button берём из них первый(Так же можно получать по классам, по id и так далее)
//    let coord = button.getBoundingClientRect(); // Получаем координаты элемента
//    let x = coord.x; // Координаты по оси x
//    let y = coord.y; // Координаты по оси y
//    let width = coord.width; // Получаем ширину элемента
//    let height = coord.height;
//    button.style.left = '605px';
//});


$('#secondbtn1').on("click", function () {
    $('html body').toggleClass("lock");
    let button = document.getElementById('secondbtn1'); // Получаем элементы по тегу button берём из них первый(Так же можно получать по классам, по id и так далее)
    let coord = button.getBoundingClientRect(); // Получаем координаты элемента
    let x = coord.x; // Координаты по оси x
    let y = coord.y; // Координаты по оси y
    let width = coord.width; // Получаем ширину элемента
    let height = coord.height;
    button.style.left ='-300px';
    $('#secondbtn1').toggleClass("click");
    $('.sidebar').removeClass("show");
    $('.sidebar2').removeClass("show");
    $('.sidebar3').removeClass("show");
    var $overlay = $('.overlay'),
        openClass = 'is-open';
    $overlay.removeClass(openClass);
});

$('.overlay').on("click", function () {
    $('html body').removeClass("lock");
    $('#mybtn').removeClass("click");
    $('.sidebar').removeClass("show");
    $('.sidebar2').removeClass("show");
    $('#secondbtn1').removeClass("click");
    $('.sidebar3').removeClass("show");
    var $overlay = $('.overlay'),
        openClass = 'is-open';
    $overlay.removeClass(openClass);
    let button = document.getElementById('secondbtn1'); // Получаем элементы по тегу button берём из них первый(Так же можно получать по классам, по id и так далее)
    let coord = button.getBoundingClientRect(); // Получаем координаты элемента
    let x = coord.x; // Координаты по оси x
    let y = coord.y; // Координаты по оси y
    let width = coord.width; // Получаем ширину элемента
    let height = coord.height;
    button.style.left = '-300px';
});


//$('#').click(function (e) {
//    e.preventDefault();
//});


let btnId = document.querySelectorAll('[id^="Catbtn_"]');
let sidebar2Id = document.querySelectorAll('[id^="s_"]');




$(btnId[0]).on("mouseenter", function () {
    $(sidebar2Id[0]).addClass("show");
    $(sidebar2Id[0]).css('z-index', 10);
    $(sidebar2Id[0]).siblings().css('z-index', 8);
});
$(btnId[1]).on("mouseenter", function () {
    $(sidebar2Id[1]).addClass("show");
    $(sidebar2Id[1]).css('z-index', 10);
    $(sidebar2Id[1]).siblings().css('z-index', 8);

});
$(btnId[2]).on("mouseenter", function () {
    $(sidebar2Id[2]).addClass("show");
    $(sidebar2Id[2]).css('z-index', 10);
    $(sidebar2Id[2]).siblings().css('z-index', 8);

});
$(btnId[3]).on("mouseenter", function () {
    $(sidebar2Id[3]).addClass("show");
    $(sidebar2Id[3]).css('z-index', 10);
    $(sidebar2Id[3]).siblings().css('z-index', 8);

});
$(btnId[4]).on("mouseenter", function () {
    $(sidebar2Id[4]).addClass("show");
    $(sidebar2Id[4]).css('z-index', 10);
    $(sidebar2Id[4]).siblings().css('z-index', 8);
});
$(btnId[5]).on("mouseenter", function () {
    $(sidebar2Id[5]).addClass("show");
    $(sidebar2Id[5]).css('z-index', 10);
    $(sidebar2Id[5]).siblings().css('z-index', 8);
});
$(btnId[6]).on("mouseenter", function () {
    $(sidebar2Id[6]).addClass("show");
    $(sidebar2Id[6]).css('z-index', 10);
    $(sidebar2Id[6]).siblings().css('z-index', 8);
});
$(btnId[7]).on("mouseenter", function () {
    $(sidebar2Id[7]).addClass("show");
    $(sidebar2Id[7]).css('z-index', 10);
    $(sidebar2Id[7]).siblings().css('z-index', 8);
});
$(btnId[8]).on("mouseenter", function () {
    $(sidebar2Id[8]).addClass("show");
    $(sidebar2Id[8]).css('z-index', 10);
    $(sidebar2Id[8]).siblings().css('z-index', 8);
});
$(btnId[9]).on("mouseenter", function () {
    $(sidebar2Id[9]).addClass("show");
    $(sidebar2Id[9]).css('z-index', 10);
    $(sidebar2Id[9]).siblings().css('z-index', 8);

});
$(btnId[10]).on("mouseenter", function () { 
    $(sidebar2Id[10]).addClass("show"); 
    $(sidebar2Id[10]).css('z-index', 10);
    $(sidebar2Id[10]).siblings().css('z-index', 8);

});

$(btnId[11]).on("mouseenter", function () { 
    $(sidebar2Id[11]).addClass("show"); 
    $(sidebar2Id[11]).css('z-index', 10);
    $(sidebar2Id[11]).siblings().css('z-index', 8);

});

$(btnId[12]).on("mouseenter", function () { 
    $(sidebar2Id[12]).addClass("show"); 
    $(sidebar2Id[12]).css('z-index', 10);
    $(sidebar2Id[12]).siblings().css('z-index', 8);

});

$(btnId[13]).on("mouseenter", function () { 
    $(sidebar2Id[13]).addClass("show"); 
    $(sidebar2Id[13]).css('z-index', 10);
    $(sidebar2Id[13]).siblings().css('z-index', 8);

});

$(btnId[14]).on("mouseenter", function () { 
    $(sidebar2Id[14]).addClass("show"); 
    $(sidebar2Id[14]).css('z-index', 10);
    $(sidebar2Id[14]).siblings().css('z-index', 8);

});

$(btnId[15]).on("mouseenter", function () { 
    $(sidebar2Id[15]).addClass("show"); 
    $(sidebar2Id[15]).css('z-index', 10);
    $(sidebar2Id[15]).siblings().css('z-index', 8);

});

$(btnId[16]).on("mouseenter", function () { 
    $(sidebar2Id[16]).addClass("show"); 
    $(sidebar2Id[16]).css('z-index', 10);
    $(sidebar2Id[16]).siblings().css('z-index', 8);

});

$(btnId[17]).on("mouseenter", function () { 
    $(sidebar2Id[17]).addClass("show"); 
    $(sidebar2Id[17]).css('z-index', 10);
    $(sidebar2Id[17]).siblings().css('z-index', 8);

});

$(btnId[18]).on("mouseenter", function () { 
    $(sidebar2Id[18]).addClass("show"); 
    $(sidebar2Id[18]).css('z-index', 10);
    $(sidebar2Id[18]).siblings().css('z-index', 8);

});

$(btnId[19]).on("mouseenter", function () { 
    $(sidebar2Id[19]).addClass("show"); 
    $(sidebar2Id[19]).css('z-index', 10);
    $(sidebar2Id[19]).siblings().css('z-index', 8);

});

$(btnId[20]).on("mouseenter", function () { 
    $(sidebar2Id[20]).addClass("show"); 
    $(sidebar2Id[20]).css('z-index', 10);
    $(sidebar2Id[20]).siblings().css('z-index', 8);

});

$(btnId[21]).on("mouseenter", function () {
    $(sidebar2Id[21]).addClass("show"); 
    $(sidebar2Id[21]).css('z-index', 10);
    $(sidebar2Id[21]).siblings().css('z-index', 8);

});
$(btnId[22]).on("mouseenter", function () {
    $(sidebar2Id[22]).addClass("show");
    $(sidebar2Id[22]).css('z-index', 10);
    $(sidebar2Id[22]).siblings().css('z-index', 8);

});

$.each($(btnId).on("mouseenter", function () {
    $('.sidebar3').addClass("show");
    let button = document.getElementById('secondbtn1'); // Получаем элементы по тегу button берём из них первый(Так же можно получать по классам, по id и так далее)
    let coord = button.getBoundingClientRect(); // Получаем координаты элемента
    let x = coord.x; // Координаты по оси x
    let y = coord.y; // Координаты по оси y
    let width = coord.width; // Получаем ширину элемента
    let height = coord.height;
    button.style.left = '605px';
}));







//$('#Catbtn_1').on("mouseenter", function () {

//    $('#s_1').addClass("show");
//    let button = document.getElementById('secondbtn1'); // Получаем элементы по тегу button берём из них первый(Так же можно получать по классам, по id и так далее)
//    let coord = button.getBoundingClientRect(); // Получаем координаты элемента
//    let x = coord.x; // Координаты по оси x
//    let y = coord.y; // Координаты по оси y
//    let width = coord.width; // Получаем ширину элемента
//    let height = coord.height;
//    button.style.left = '605px';
//});