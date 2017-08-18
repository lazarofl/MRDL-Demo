using HUX.Interaction;
using HUX.Receivers;
using UnityEngine;

public class ToggleReceiver : InteractionReceiver
{
    private bool _toggled;

    protected override void OnTapped(GameObject obj, InteractionManager.InteractionEventArgs eventArgs)
    {
        _toggled = !_toggled;

        for (int i = 0; i < Targets.Count; i++)
            Targets[i].SetActive(_toggled);
    }
}
