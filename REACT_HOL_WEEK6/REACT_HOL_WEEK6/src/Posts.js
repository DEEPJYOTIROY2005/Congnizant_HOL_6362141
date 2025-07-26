// src/Posts.js

import React, { Component } from 'react';

// Post model class defined inside the same file
class Post {
  constructor(userId, id, title, body) {
    this.userId = userId;
    this.id = id;
    this.title = title;
    this.body = body;
  }
}

class Posts extends Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
      error: null
    };
  }

  // Load posts from API and convert to Post objects
  loadPosts() {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then(response => {
        if (!response.ok) {
          throw new Error("Failed to fetch posts");
        }
        return response.json();
      })
      .then(data => {
        const postList = data.map(
          p => new Post(p.userId, p.id, p.title, p.body)
        );
        this.setState({ posts: postList });
      })
      .catch(err => {
        this.setState({ error: err.message });
      });
  }

  // Lifecycle hook to load posts after mounting
  componentDidMount() {
    this.loadPosts();
  }

  // Catch rendering or lifecycle errors
  componentDidCatch(error, info) {
    alert("Error occurred: " + error);
  }

  render() {
    const { posts, error } = this.state;

    return (
      <div style={{ padding: '20px' }}>
        <h1>Blog Posts</h1>
        {error && <p style={{ color: 'red' }}>{error}</p>}
        {posts.map(post => (
          <div key={post.id} style={{ marginBottom: '20px' }}>
            <h3>{post.title}</h3>
            <p>{post.body}</p>
            <hr />
          </div>
        ))}
      </div>
    );
  }
}

export default Posts;
