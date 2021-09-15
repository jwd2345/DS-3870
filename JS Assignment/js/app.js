var arrEmployees;
$.getJSON("https://www.swollenhippo.com/EmployeesByAPIKey.php?APIKey=Mickey2021!", function(result){
    console.log(result);
    arrEmployees = result;
    buildEmployeeCard();
    $.each(result,function(i,person){
        console.log(person,FirstName);
        console.log(person,FirstName +' ' + person.LastName);
        $('txtEmail').val(person.Email);
    })
})


function buildEmployeeCard(){
    $.each(arrEmployees,function(i,person){
        if(person.FirstName !='John'){
            let strHTML = '<div class="card col-3 mt-5 ,l-3>';
            strHTML += 'img src="images/profile.png" alt="Profile Image" style="margin:auto; max-width:100%">';
            strHTML += '<h3 class="text-center"><a href="mailto:' + person.Email + '"' + person.FirstName + personLastName + '</a></h3>';
            strHTML +='<h4 class="text-center>' + personPosition + '</h4>';
            strHTML +='<h4 class="mt-3">Profile Details</h4>';
            strHTML +='<p>Hire Date: ' + personHireDate + '</p>' ;
            strHTML +='<p class="txtHourlyRate" date-rate"' + personHourlyRate + '">HourlyRate:-' + person.personHourlyRate + '</p>';
            strHTML +='<h4 class="mt-3">Pay Calculations</h4>';
            strHTML +='<div class=form-group mb-0>';
            strHTML +='<label class="mr-2">Hours Worked</label>';
            strHTML +='<input class="txtHours">';
            strHTML +='</div>';
            strHTML +='<div class="form-group">';
            strHTML +='<label class="mr-2">Total Pay</label>';
            strHTML +='<input class="txtTotalPay" disabled>';
            strHTML += '<button class="btn btn-primary btn-block btnCalculatePay">Calculate</button'
            strHTML += '</div>'
            strHTML += '</div>'
            $('divEmployeeCards').append(strHTML);
        }

    });
}

$(document).on('click','btnCalculatePay,function'() {
    let decHours = $(this).closet('.card').find('.txthours').val();
    let  decRate = $(this).closet('.card').find('.txtHourlyRate').val().split(': ')[1];
    $(this).closet('.card').find('.txtTotalPay').val(decHours * decRate);
})