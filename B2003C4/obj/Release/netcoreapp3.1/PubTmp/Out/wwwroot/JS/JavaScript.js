function Device() {
	if (navigator.userAgent.match(/(Android)/i)) {
		return "Mobile";
	}
	else if (navigator.userAgent.match(/(iPhone|iPod)/i)) {
		return "iPhone";
	}
	else {
		return "PC";
	}
}