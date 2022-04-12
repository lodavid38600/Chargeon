const mongoose = require("mongoose");

const PostsModel = mongoose.model(
  "node-api",
  {
    author: {
      type: String,
      required: true
    },
    message: {
      type: String,
      required: true
    },

  },
  "posts"
);

module.exports = { PostsModel };