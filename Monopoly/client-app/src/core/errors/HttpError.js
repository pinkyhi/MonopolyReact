class HttpError extends Error {
    constructor(message, response) {
      super(message);
      this.response = response;
      this.name = "HttpError";
    }
}

export default HttpError