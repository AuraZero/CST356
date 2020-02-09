
function validate() {
    
    document.getElementById('name-error').style.visibility = 'hidden'
    document.getElementById('password-error').style.visibility = 'hidden'

    var nameField = document.getElementById('name-field').value
    var passwordField = document.getElementById('password-field').value

    if (nameField == '') {
        document.getElementById('name-error').style.visibility = 'visible'
        document.getElementById('name-error').innerHTML = "required"
    }

    if (passwordField == '') {
        document.getElementById('password-error').style.visibility = 'visible'
        document.getElementById('password-error').innerHTML = "required"
    }
}