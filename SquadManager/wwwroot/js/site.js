function changeMenu(menuToChange) {
    $('nav').find('li.btn-active').removeClass('btn-active');

    if (menuToChange != 'home') {
        $('nav [data-menu="' + menuToChange + '"]').addClass('btn-active');
    }
}