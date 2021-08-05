
    $(document).ready(function () {
        $('.btnStatus').click(function (event) {
            var ID = $(this).attr("id");  //id değerini alıyoruz
            $.ajax({
                type: 'POST',
                url: '/Heading/SetStatus/' + ID,  //işlem yaptığımız sayfayı belirtiyoruz
                dataType: 'json',
                success: function () {
                    location.reload();
                },
                error: function () {
                    alert('Hata oluştu.');
                }
            });


        });
        });