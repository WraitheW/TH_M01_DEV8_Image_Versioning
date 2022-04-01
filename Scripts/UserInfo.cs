using UnityEngine;

public class UserInfo : MonoBehaviour
{
     public string UserID { get; private set; }
     string UserName;
     string UserPassword;
     string Level;
     string Gold;

    public void SetCredentials(string username, string userPassword)
    {
        UserName = username;
        UserPassword = userPassword;
    }

    public void SetID(string id)
    {
        UserID = id;
    }
}
