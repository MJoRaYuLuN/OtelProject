<!-- Preloader -->		
		$(window).load(function() { // makes sure the whole site is loaded
			$('#status').fadeOut(); // will first fade out the loading animation
			$('#preloader').delay(350).fadeOut('slow'); // will fade out the white DIV that covers the website.
			$('body').delay(350).css({'overflow':'visible'});
		})
	
<!-- Quantity input -->     
jQuery(document).ready(function(){
    // This button will increment the value
    $('.qtyplus').click(function(e){
        // Stop acting like a button
        e.preventDefault();
        // Get the field name
        fieldName = $(this).attr('name');
        // Get its current value
        var currentVal = parseInt($('input[name='+fieldName+']').val());
        // If is not undefined
        if (!isNaN(currentVal)) {
            // Increment
            $('input[name='+fieldName+']').val(currentVal + 1);
        } else {
            // Otherwise put a 0 there
            $('input[name='+fieldName+']').val(0);
        }
    });
    // This button will decrement the value till 0
    $(".qtyminus").click(function(e) {
        // Stop acting like a button
        e.preventDefault();
        // Get the field name
        fieldName = $(this).attr('name');
        // Get its current value
        var currentVal = parseInt($('input[name='+fieldName+']').val());
        // If it isn't undefined or its greater than 0
        if (!isNaN(currentVal) && currentVal > 0) {
            // Decrement one
            $('input[name='+fieldName+']').val(currentVal - 1);
        } else {
            // Otherwise put a 0 there
            $('input[name='+fieldName+']').val(0);
        }
    });

});


// Open modal window on click  
jQuery(document).ready(function(){
		$('#modal-rooms-open').on('click', function(e) {
			var mod = $('#main'),
				modal = $('#modal-offers');
				mod.animate({ opacity: 0 }, 400, function(){
				$('html,body').scrollTop(0);
				modal.addClass('modal-active').fadeIn(400);
			});
			e.preventDefault();

			$('.modal-close').on('click', function(e) {
				modal.removeClass('modal-active').fadeOut(400, function(){
					mod.animate({ opacity: 1 }, 400);
				});
				e.preventDefault();
			});
		});
		
		$('#modal-weather-open').on('click', function(e) {
			var mod = $('#main'),
				modal = $('#modal-weather');
				mod.animate({ opacity: 0 }, 400, function(){
				$('html,body').scrollTop(0);
				modal.addClass('modal-active').fadeIn(400);
			});
			e.preventDefault();

			$('.modal-close').on('click', function(e) {
				modal.removeClass('modal-active').fadeOut(400, function(){
					mod.animate({ opacity: 1 }, 400);
				});
				e.preventDefault();
			});
		});
		
		$('#modal-about-open').on('click', function(e) {
			var mod = $('#main'),
				modal = $('#modal-about');
				mod.animate({ opacity: 0 }, 400, function(){
				$('html,body').scrollTop(0);
				modal.addClass('modal-active').fadeIn(400);
			});
			e.preventDefault();

			$('.modal-close').on('click', function(e) {
				modal.removeClass('modal-active').fadeOut(400, function(){
					mod.animate({ opacity: 1 }, 400);
				});
				e.preventDefault();
			});
		});
		
		$('#modal-contacts-open').on('click', function(e) {
			var mod = $('#main'),
				modal = $('#modal-contacts');
 				mod.animate({ opacity: 0 }, 400, function(){
				$('html,body').scrollTop(0);
				modal.addClass('modal-active').fadeIn(400);
					//set up markers 
		var myMarkers = {"markers": [
				{"latitude": "51.511732", "longitude":"-0.123270", "icon": "img/map-marker2.png"}
			]
		};
		
		//set up map options
		$("#map").mapmarker({
			zoom	: 14,
			center	: 'Covent Garden London',
			markers	: myMarkers
		});
			});
			e.preventDefault();
	
			$('.modal-close').on('click', function(e) {
				modal.removeClass('modal-active').fadeOut(400, function(){
					mod.animate({ opacity: 1 }, 400);
				});
				e.preventDefault();
			});
		});
		
		});


//Pace holder
$('input, textarea').placeholder();	