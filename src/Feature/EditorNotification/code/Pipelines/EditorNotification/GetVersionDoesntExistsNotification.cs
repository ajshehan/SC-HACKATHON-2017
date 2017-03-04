using Sitecore.Pipelines.GetPageEditorNotifications;

namespace Sitecore.Feature.EditorNotification.Pipelines.EditorNotification
{
    public class GetVersionDoesntExistsNotification : GetPageEditorNotificationsProcessor
    {
        public override void Process(GetPageEditorNotificationsArgs arguments)
        {
            var description = "If you publish now, the current item may not render properly because the following items have the same name. Click the links below to review these items:";

            var editorNotification = new PageEditorNotification(description, PageEditorNotificationType.Warning);

            arguments.Notifications.Add(editorNotification);
        }
    }
}