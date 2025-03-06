public class HistoryNode {
    public string url;
    public HistoryNode next = null;
    public HistoryNode prev = null;

    public HistoryNode(string url) {
        this.url = url;
    }
}

public class BrowserHistory {
    HistoryNode home;
    HistoryNode current;

    public BrowserHistory(string homepage) {
        home = new HistoryNode(homepage);
        current = home;
    }
    
    public void Visit(string url) {
        var next = new HistoryNode(url);
        current.next = next;
        next.prev = current;
        current = next;
    }
    
    public string Back(int steps) {
        for (int i = 0; i < steps; i++) {
            if (current.prev == null)
                break;
            current = current.prev;
        }

        return current.url;
    }
    
    public string Forward(int steps) {
        for (int i = 0; i < steps; i++) {
            if (current.next == null)
                break;
            current = current.next;
        }

        return current.url;
    }
}

