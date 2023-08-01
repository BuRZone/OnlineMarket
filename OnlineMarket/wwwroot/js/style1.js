$('#mybtn').on("click", function () {
    $('html body').toggleClass("lock");
    $('#secondbtn1').addClass("click");
    $('.sidebar').toggleClass("show");
    let button = document.getElementById('secondbtn1');
    button.style.left = '300px';
    $('.overlay').addClass("show");
});


$('#secondbtn1').on("click", function () {
    $('html body').toggleClass("lock");
    let button = document.getElementById('secondbtn1'); 
    button.style.left ='-300px';
    $('#secondbtn1').toggleClass("click");
    $('.sidebar').removeClass("show");
    $('.sidebar2').removeClass("show");
    $('.sidebar3').removeClass("show");
    $('.overlay').removeClass("show");
});

$('.overlay').on("click", function () {
    $('html body').removeClass("lock");
    $('#mybtn').removeClass("click");
    $('.sidebar').removeClass("show");
    $('.sidebar2').removeClass("show");
    $('#secondbtn1').removeClass("click");
    $('.sidebar3').removeClass("show");
    $('.overlay').removeClass("show");
    let button = document.getElementById('secondbtn1'); 
    button.style.left = '-300px';
});

let btnId = document.querySelectorAll('[id^="Catbtn_"]');
let sidebar2Id = document.querySelectorAll('[id^="s_"]');


$('[id^="Catbtn_"]').on('mouseenter', function () {
    var ID = $(this).attr('id').replace('Catbtn_', '');
    var sidebarID = $(document.querySelector(`[id="s_${ID}"]`));
    sidebarID.addClass("show");
    sidebarID.css('z-index', 10);
    sidebarID.siblings().css('z-index', 8);
});

$.each($(btnId).on("mouseenter", function () {
    $('.sidebar3').addClass("show");
    let button = document.getElementById('secondbtn1');
    button.style.left = '605px';
}));




//    let $button = $(document.querySelector('#search1'))
//    let $search = $(document.querySelector('[name="searchString"]'))

//$search.addEventListener("input", function (a) {
//        const value = a.target.value;
//    if(value == null)
//    {
//        $button.click(function (e) {

//            e.preventDefault();

//        });
//    }

//    });



