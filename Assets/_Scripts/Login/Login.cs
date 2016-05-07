using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class Login : MonoBehaviour {

    //Using CamelCase Variables due to PHP to SQL delivery
    public Text ProfileName;
	public Text Email;
	public Text FirstName;
	public Text LastName;
	public Text Password;
	public Text PasswordRepeat;

	public Text profileLogin;
	public Text profilePassword;

	private string createAccountURL = "http://127.0.0.1/CreateAccount.php";
	private string loginURL;

	public void CreateAccount(){
		if (Password.ToString() == PasswordRepeat.ToString()) {
            Debug.Log("Starting Account Creator CoRoutine.");
			StartCoroutine ("AccountCreator");
		}
	}

	IEnumerator AccountCreator(){
		WWWForm form = new WWWForm ();
		form.AddField("Email", Email.ToString ());
        form.AddField("Password", Password.ToString());
        form.AddField("ProfileName", ProfileName.ToString());
        form.AddField("FirstName", FirstName.ToString());
        form.AddField("LastName", LastName.ToString());
		

		WWW createAccountWWW = new WWW (createAccountURL, form);
		yield return createAccountWWW;		//Wait for PHP to respond

		if (createAccountWWW.error != null) {
			Debug.LogError ("Cannot Connect to Account Creation");
		} else {
			string createAccountReturn = createAccountWWW.text;
			if (createAccountReturn == "Success") {
				Debug.Log ("Successful PHP Connection");
			}
		}
	}

	public void LoginToSystem(){

	}
}
