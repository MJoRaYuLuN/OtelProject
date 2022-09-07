$(function() {
    $('.dropify').dropify();

    var drEvent = $('#dropify-event').dropify();
    drEvent.on('dropify.beforeClear', function(event, element) {
        return confirm("\"" + element.file.name + "\" silmek istediğinize emin misiniz?");
    });
    var drEvent = $('#dropify-event1').dropify();
    drEvent.on('dropify.beforeClear', function(event, element) {
        return confirm("\"" + element.file.name + "\" silmek istediğinize emin misiniz?");
    });
    var drEvent = $('#dropify-event2').dropify();
    drEvent.on('dropify.beforeClear', function(event, element) {
        return confirm("\"" + element.file.name + "\" silmek istediğinize emin misiniz?");
    });
    var drEvent = $('#dropify-event3').dropify();
    drEvent.on('dropify.beforeClear', function(event, element) {
        return confirm("\"" + element.file.name + "\" silmek istediğinize emin misiniz?");
    });
    var drEvent = $('#dropify-event4').dropify();
    drEvent.on('dropify.beforeClear', function(event, element) {
        return confirm("\"" + element.file.name + "\" silmek istediğinize emin misiniz?");
    });
    var drEvent = $('#dropify-event5').dropify();
    drEvent.on('dropify.beforeClear', function(event, element) {
        return confirm("\"" + element.file.name + "\" silmek istediğinize emin misiniz?");
    });

    drEvent.on('dropify.afterClear', function(event, element) {
        alert('File deleted');
    });
	
    $('.dropify-en').dropify({
        messages: {
            default: 'Bir dosyayı buraya sürükleyip bırakın veya tıklayın',
            replace: 'Bir dosyayı sürükleyip bırakın veya değiştirmek için tıklayın',
            remove: 'Kaldırın',
            error: 'Üzgünüm, dosya çok büyük'
        }
    });
});