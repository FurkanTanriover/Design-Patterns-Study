using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverManager : MonoSingleton<ObserverManager>
{
    private List<Subject> subjects = null;

    public void RegisterSubject(Subject subject) // tamam seni kaydettim subject
    {
        if(subjects==null)
        {
            subjects = new List<Subject>();
        }

        subjects.Add(subject);
    }

    public void RegisterObserver(Observer observer, SubjectType subjectType)
    {
        foreach(var subject in subjects)
        {
            if(subject.SubjectType==subjectType)  // subjectleri gez subject type ý benim istediðimle ayný olanla observerýmý kaydet.
            {
                subject.RegisterObserver(observer);
            }
        }
    }
}

public enum NotificationType
{
    ForwardButton,
    BackButton,
    LeftButton,
    RightButton
}

public enum SubjectType
{
    MovementPanel
}
