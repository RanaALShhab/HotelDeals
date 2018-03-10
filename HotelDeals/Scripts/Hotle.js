
function search(val) {

    var value = $("#txtSearch").val();

    $.ajax({
        url: '/Hotel/Search',
        type: 'POST',
        data: { Paraname: value, valuetap: val },
        success: function (data) {
            if (val == 1) {
                $("#HotelInfo").html(data)
            }
            else if (val == 2) {
               
                $("#Offersdestination").html(data)
               
            }
            else {
                $("#hotelPricingInfo").html(data)
            }


        },
        error: function () {

        },

    });

    
}