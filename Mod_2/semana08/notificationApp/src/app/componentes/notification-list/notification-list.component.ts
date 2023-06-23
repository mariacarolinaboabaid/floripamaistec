import { Component } from '@angular/core';
import { elementAt } from 'rxjs';

@Component({
  selector: 'app-notification-list',
  templateUrl: './notification-list.component.html',
  styleUrls: ['./notification-list.component.scss']
})
export class NotificationListComponent {

  notifications = [
    {
      id: 1,
      title: "WhatsApp",
      subtitle: "Alexandre Henrique send you a message!",
      date: "22/03/2023",
      read: false
    },
    {
      id: 2,
      title: "Instagram",
      subtitle: "Mariana Fernandes like your post!",
      date: "22/03/2023",
      read: false
    },
    {
      id: 3,
      title: "Gmail",
      subtitle: "You just receive a new e-mail. Check your inbox!",
      date: "23/03/2023",
      read: false
    },
    {
      id: 4,
      title: "Nubank",
      subtitle: "Your invoice has closed!",
      date: "23/03/2023",
      read: false
    }
  ]

  readNotification(notification: any) {
    this.notifications.forEach((element) => {
      if (element.id === notification.id) {
        element.read = true;
      }
    })
  }

  
}