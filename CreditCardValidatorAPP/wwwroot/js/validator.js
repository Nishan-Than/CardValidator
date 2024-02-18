var uri = 'https://localhost:44323/api/CardValidator';
function formatItem(item) {
    return item.Name + ': $' + item.Price;
}

function validate() {
    var creditCardNo = $('#cardNo').val();

    var requestData = {
        creditCardNumber: creditCardNo.replace(/\s+/g, '')
    };

    $.ajax({
        url: 'https://localhost:44323/api/CardValidator',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(creditCardNo),
        success: function (data) {
            // Handle success
        },
        error: function (jqXHR, textStatus, errorThrown) {
            // Handle error
        }
    });
    
}