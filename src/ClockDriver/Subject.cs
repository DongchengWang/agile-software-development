﻿using System.Collections.Generic;

namespace AgileSoftwareDevelopment.ClockDriver {
    public class Subject {
        private IList<Observer> itsObservers = new List<Observer>();

        public void NotifyObservers() {
            foreach (var observer in itsObservers) {
                observer.Update();
            }
        }

        public void RegisterObserver(Observer observer) {
            itsObservers.Add(observer);
        }
    }
}
